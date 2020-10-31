# TimeMarker
This application allows you to create a dated file with timestamps. Optionally you can record a voice recording of a settings set length as to recall what the timestamp was for.

## Features

1. Shortcut Key Binding (No initial Keyset)
1. Audio Recording stored WITH the timestamp
1. Customizable Audio Recording Length
1. Exportable in CSV (Audio files are exported next to csv file with id and timestamp information as the filename)

## Future Features

1. Export To Excel
1. Export To HTML
1. Provide Custom Text Notes
1. Online version
1. Configurable storage of settings file.

if you have a suggestion please submit an issue. provide as much detail as you can. Feature Request Issues will be labeled when reviewed.

## Known Issues

1. Dependencies of SkyhoshiLibraries are private, will need to be package as Nuget pacakages and as such ``` Skyhoshi.App.TimeMarker-Local ``` does not load or compile correctly. 
1. settings are stored beside the executable. settings will move to C:\users\{username}\.SkyhoshiApps\{App Name} in the future for puruposes of backup. this will be configurable as well. 