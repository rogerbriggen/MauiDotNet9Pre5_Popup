# XamlC Issue with popups with .Net 9 Preview 5

This project shows the problem with XamlC and CommunityToolkit:Popup with .Net 9 Preview 5

Just do a 
```
dotnet build
```
and you will see the following error
```
MauiDotNet9Pre5_Popup\SimplePopup.xaml(6,6): XamlC error XC0009: No property, BindableProperty, or event found for "Content", or mismatching type between value and property.
```

You can change to dotnet 9 preview 5 by changing the global.json file to
```
{
  "sdk": {
	"version": "9.0.100-preview.5.24307.3",
	"rollForward": "disable"
  }
}
```

You can change to dotnet 9 preview 3 by changing the global.json file to
```
{
  "sdk": {
	"version": "9.0.100-preview.3.24204.13",
	"rollForward": "disable"
  }
}
```

You can change to dotnet 8 by changing the global.json file to
```
{
  "sdk": {
	"version": "8.0.100",
    "rollForward": "feature"
  }
}
```

Make sure to delete obj and bin folders before building the project if you switch between dotnet 9 preview 3 and 5.


* It works fine with .net 9 preview 3 sdk (9.0.100-preview.3.24204.13) targeting dotnet 9.
* It works fine with .net 8 sdk (8.0.204) targeting dotnet 8.