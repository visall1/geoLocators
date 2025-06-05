# 🌍 GeoLocator

GeoLocator is a simple C# console application that takes an IP address and fetches geolocation data using the [ipinfo.io](https://ipinfo.io/) API. It returns details such as city, region, country, coordinates, postal code, and organization, and generates a direct link to Google Maps for easy location viewing.

---

## 🚀 Features

- Fetches location data from IP addresses
- Displays:
  - IP Address
  - Country
  - Region
  - City
  - Postal Code
  - Coordinates (Latitude & Longitude)
  - Organization (ASN)
- Generates a Google Maps link based on coordinates

---

## 🧰 Technologies Used

- C# (.NET)
- `HttpClient` for making HTTP requests
- `Newtonsoft.Json` for parsing JSON
- [ipinfo.io](https://ipinfo.io) for geolocation data

---

## 📦 Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed
- Internet connection
- An IP address to lookup

---

## 📄 How to Use

1. Clone the repository or copy the code:

    ```bash
    git clone https://github.com/yourusername/GeoLocator.git
    cd GeoLocator
    ```

2. Build and run the application:

    ```bash
    dotnet run
    ```

3. Input an IP address when prompted. The program will fetch and display relevant location data.

---

## 📸 Example Output

 ```Enter IP Address: 8.8.8.8
  [+] Request Successfully Made
  IP: 8.8.8.8
  Country: US
  City: Mountain View
  Coordinates: 37.3860,-122.0840
  Postal Code: 94035
  Region: California
  ANS: AS15169 Google LLC
  Google Map: https://www.google.com/maps/?q=37.3860,-122.0840
  ```

---

## ⚠️ Notes

- The app uses the free tier of [ipinfo.io](https://ipinfo.io/), which may be rate-limited.
- No API key is required for basic usage, but you can add one for more detailed data or higher limits.

---

## 📜 License

This project is licensed under the MIT License.

