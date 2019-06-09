# Ipify

Ipify is an unofficial library (.NET Standard 2.0) that uses requests to Ipify.org to obtain a client Public IP address. You can also use it to obtain geolocation datas from an IP address, but require a token.

## Installation

### Nuget

```
dotnet add package Ipify --version 1.0.1
```

## Usages

- Add reference in your project

- import library in code : `using Ipify;`

### Getting IP Address

#### IPv4

Getting IPv4 Address:

```csharp
var ip = IpifyIp.GetPublicIp(); //Will return IP Address as a string.
```

Getting IPv4 Address Async:

```csharp
using System.Threading.Tasks;

// code ommited 

var ip = await IpifyIp.GetPublicIpAsync(); 
```

#### IPv6

Getting IPv6 Address:

```csharp
var ip = IpifyIpv6.GetPublicIpV6();
```

Getting IPv6 Address Async:

```csharp
var ip = await IpifyIpv6.GetPublicIpV6Async();
```

### Getting Geolocation Data:

Geolocation Format example (`json`):

```json
{
  "ip":"8.8.8.8",
  "location": {
    "country": "US",
    "region": "California",
    "city": "Mountain View",
    "lat": "37.40599",
    "lng": "-122.078514",
    "postalCode": "94043",
    "timezone": "-08:00"
  }
}
```

Getting Geolocation Data from IP Address:

```csharp
var token = "YOUR_TOKEN";
var ip = "YOUR_IP_STRING_FORMAT";
var geoIP = IpifyGeoIp.RequestGeoIp(token,ip);
```

Getting Geolocation Data from IP Address:

```csharp
var token = "YOUR_TOKEN";
var ip = "YOUR_IP_STRING_FORMAT";
var geoIP = await IpifyGeoIp.RequestGeoIpAsync(token,ip);
```

### Other Usage example:

In a class:

```csharp
using Ipify;

//Code ommited
public class Pyfi
{
    public string Token { get; set; }
    public GeoIp GeoIp { get; private set; } 
    public string Ip { get; set; }

    public Pyfi(string token = null, string ip = null)
    {
        Token = token;
        Ip = ip;
        GeoIp = new GeoIp();
    }
     
    public GeoIp RequestGeoIp()
    {
        return IpifyGeoIp.RequestGeoIp(Token, Ip);
    }

    public async Task<GeoIp> RequestGeoIpAsync()
    {
        return await IpifyGeoIp.RequestGeoIpAsync(Token,Ip);
    }

    private string GetIp()
    {
        return IpifyIp.GetPublicIp();
    }

    private async Task<string> GetIpAsync()
    {
        return await IpifyIp.GetPublicIpAsync();
    }

    public void SetIp(string ip = null)
    {
        Ip = ip ?? Ip ?? GetIp();
    }

    public async Task SetIpAsync(string ip = null)
    {
        Ip = ip ?? Ip ?? await GetIpAsync();
    }
}
```
