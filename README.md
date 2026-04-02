# Quiet Old Birds

Reduces the volume of Old Birds in Lethal Company to save your ears. _Should_ work with sound replacement mods

## Dev Setup

- Rename `QuietOldBirds.template.csproj.user` to `QuietOldBirds.csproj.user`, then update `PluginDirectory` to your bepinex plugins folder 
- By default game libs are stored in a directory relative to the git repository root `./_lcdata/Managed`. I recommend making this a symlink to your `Lethal Company_Data` folder
    - For example if this repo is in `D:\SomeFolder\QuietOldBirds`, make the symlink at `D:SomeFolder\_lcdata\`
    - Alternatively update the links manually in `QuietOldBirds.csproj`