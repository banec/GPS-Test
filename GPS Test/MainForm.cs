using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Geolocation;

namespace GPS_Test {
    public partial class MainForm : Form {
        private Geolocator geolocator = null;

        public MainForm() {
            InitializeComponent();
            geolocator = new Geolocator();
            geolocator.ReportInterval = 2000;

            if (geolocator != null) {
                geolocator.PositionChanged += Geolocator_PositionChanged;
                geolocator.StatusChanged += Geolocator_StatusChanged;
            } else {
                statusLabel.Text = "GPS init failed!";
            }
        }

         private void Geolocator_StatusChanged(Geolocator sender, StatusChangedEventArgs args) {
            try {
                statusLabel.Text = GetStatusString(geolocator.LocationStatus);
            } catch (System.UnauthorizedAccessException) {
                statusLabel.Text = "No data";
            } catch (TaskCanceledException) {
                statusLabel.Text = "Cancelled";
            } catch (Exception ex) {
                statusLabel.Text = ex.Message;
            }
        }

        async private void Geolocator_PositionChanged(Geolocator sender, PositionChangedEventArgs args) {
            try {
                // Carry out the operation
                Geoposition pos = await sender.GetGeopositionAsync();

                latTB.Text = pos.Coordinate.Latitude.ToString();
                longTB.Text = pos.Coordinate.Longitude.ToString();

                coordinateLabel.Text = "Accuracy: " + pos.Coordinate.Accuracy.ToString();
                coordinateLabel.Text += " Time: " + pos.Coordinate.Timestamp.ToString("HH:mm:ss");
                if (pos.Coordinate.Altitude != null) {
                    coordinateLabel.Text += " Altitude: " + pos.Coordinate.Altitude.ToString();
                }
                if (pos.Coordinate.Heading != null) {
                    coordinateLabel.Text += " Heading: " + pos.Coordinate.Heading.ToString();
                }
                if (pos.Coordinate.Speed != null) {
                    coordinateLabel.Text += " Speed: " + pos.Coordinate.Speed.ToString();
                }

                addressLabel.Text = "Country: " + pos.CivicAddress.Country;
                if (!String.IsNullOrEmpty(pos.CivicAddress.City)) {
                    addressLabel.Text += " City: " + pos.CivicAddress.City;
                }
            } catch (System.UnauthorizedAccessException) {
                statusLabel.Text = "No data";
            } catch (TaskCanceledException) {
                statusLabel.Text = "Cancelled";
            }
        }

        private string GetStatusString(PositionStatus status) {
            switch (status) {
                case PositionStatus.Ready:
                    return "Location is available.";
                case PositionStatus.Initializing:
                    return "Geolocation service is initializing.";
                case PositionStatus.NoData:
                    return "Location service data is not available.";
                case PositionStatus.Disabled:
                    return "Location services are disabled. Use the Settings charm to enable them.";
                case PositionStatus.NotInitialized:
                    return "Location status is not initialized because the app has not yet requested location data.";
                case PositionStatus.NotAvailable:
                    return "Location services are not supported on your system.";
                default:
                    return "Unknown PositionStatus value.";
            }
        }

        private void getMapButton_Click(object sender, EventArgs e) {
            string urlFmt = "https://maps.googleapis.com/maps/api/staticmap?center={0},{1}&zoom=15&size={2}x{3}&markers=color:blue%7C{0},{1}";
            string url = String.Format(urlFmt, latTB.Text, longTB.Text, mapPB.Width, mapPB.Height);

            //MessageBox.Show(url);

            mapPB.Load(url);
        }
    }
}
