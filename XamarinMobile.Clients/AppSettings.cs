
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace XamarinMobile.Clients
{
    public static class AppSettings
    {
        private const string DefaultBookingEndpoint = "http://sh360services-public.eastus2.cloudapp.azure.com/bookings-api/";
        private const string DefaultHotelsEndpoint = "http://sh360services-public.eastus2.cloudapp.azure.com/hotels-api/";
        private const string DefaultSuggestionsEndpoint = "http://sh360services-public.eastus2.cloudapp.azure.com/suggestions-api/";
        private const string DefaultNotifications = "http://sh360services-public.eastus2.cloudapp.azure.com/notifications-api/";
        private const string DefaultSettingsFileUrl = "http://sh360services-public.eastus2.cloudapp.azure.com/configuration-api/cfg/public-http";
        private const string DefaultImagesBaseUrl = "http://sh360imgpublic.blob.core.windows.net/";

        private static ISettings Settings => CrossSettings.Current;

        public static string BookingEndPoint
        {
            get => Settings.GetValueOrDefault(nameof(BookingEndPoint), DefaultBookingEndpoint);

            set => Settings.AddOrUpdateValue(nameof(BookingEndPoint), value);
        }

        public static string HotelEndPoint
        {
            get => Settings.GetValueOrDefault(nameof(HotelEndPoint), DefaultHotelsEndpoint);

            set => Settings.AddOrUpdateValue(nameof(HotelEndPoint), value);
        }

        public static string SuggestionsEndPoint
        {
            get => Settings.GetValueOrDefault(nameof(SuggestionsEndPoint), DefaultSuggestionsEndpoint);

            set => Settings.AddOrUpdateValue(nameof(DefaultSuggestionsEndpoint), value);
        }

        public static string NotificationEndPoint
        {
            get => Settings.GetValueOrDefault(nameof(NotificationEndPoint), DefaultNotifications);

            set => Settings.AddOrUpdateValue(nameof(NotificationEndPoint), value);
        }

        public static string ImagesBaseUrl
        {
            get => Settings.GetValueOrDefault(nameof(ImagesBaseUrl), DefaultImagesBaseUrl);

            set => Settings.AddOrUpdateValue(nameof(ImagesBaseUrl), value);
        }

    }
}

