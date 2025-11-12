using Lababa.Backend.Constants;
using Lababa.Backend.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lababa.Backend.Repositories
{
    class ApplicationSettingsRepository
    {

        private readonly string _filePath;
        private readonly char _delimiter = '=';

        public ApplicationSettingsRepository()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileNames.ShopInformation);
        }

        private ApplicationSettings LoadShopInformation()
        {
            if (!File.Exists(_filePath))
            {
                Console.WriteLine($"File doesn't exist: {_filePath}. Returning default information.");
                return new ApplicationSettings();
            }

            var appSettings = new ApplicationSettings();
            var settingsDictionary = new Dictionary<string, string>();

            try
            {
                var lines = File.ReadAllLines(_filePath);

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = line.Split(new[] { _delimiter }, 2);
                    if (parts.Length == 2)
                    {
                        var key = parts[0].Trim();
                        var value = parts[1].Trim();
                        settingsDictionary[key] = value;
                    }
                }

                settingsDictionary.TryGetValue("ShopName", out string shopName);
                appSettings.ShopName = shopName;

                settingsDictionary.TryGetValue("Address", out string address);
                appSettings.Address = address;

                settingsDictionary.TryGetValue("PhoneNumber", out string phoneNumber);
                appSettings.PhoneNumber = phoneNumber;

                settingsDictionary.TryGetValue("CurrencySymbol", out string currencySymbol);
                appSettings.CurrencySymbol = currencySymbol;

                settingsDictionary.TryGetValue("DefaultWeightUnit", out string weightUnit);

                if (!Enum.TryParse(weightUnit, out WeightUnit parsedWeightUnit))
                {
                    Console.WriteLine($"Invalid Shop Information's Weight Unit ${weightUnit}");
                    return null;
                }

                appSettings.DefaultWeightUnit = parsedWeightUnit;

                settingsDictionary.TryGetValue("ReceiptMessage", out string receiptMessage);
                appSettings.CurrencySymbol = currencySymbol;


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading shop information: {ex.Message}");
                return new ApplicationSettings();
            }

            return appSettings;
        }

        private void SaveShopInformation(ApplicationSettings appSettings)
        {
            if (appSettings == null)
            {
                throw new ArgumentNullException(nameof(appSettings));
            }

            try
            {
                var lines = new List<string>
                {
                    $"{nameof(ApplicationSettings.ShopName)}{_delimiter}{appSettings.ShopName}",
                    $"{nameof(ApplicationSettings.Address)}{_delimiter}{appSettings.Address}",
                    $"{nameof(ApplicationSettings.PhoneNumber)}{_delimiter}{appSettings.PhoneNumber}",
                    $"{nameof(ApplicationSettings.CurrencySymbol)}{_delimiter}{appSettings.CurrencySymbol}",
                    $"{nameof(ApplicationSettings.DefaultWeightUnit)}{_delimiter}{appSettings.DefaultWeightUnit}",
                    $"{nameof(ApplicationSettings.ReceiptMessage)}{_delimiter}{appSettings.ReceiptMessage}"
                };

                File.WriteAllLines(_filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving shop information: {ex.Message}");
                throw;
            }
        }
    }
}
