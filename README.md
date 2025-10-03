# DS4

## Install

```sh
wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
chmod +x dotnet-install.sh

./dotnet-install.sh --channel 8.0 --install-dir $HOME/.dotnet
```

### zshrc
```sh
echo 'export DOTNET_ROOT=$HOME/.dotnet' >> ~/.zshrc
echo 'export PATH=$DOTNET_ROOT:$PATH' >> ~/.zshrc
echo 'export DOTNET_CLI_TELEMETRY_OPTOUT=1' >> ~/.zshrc
source ~/.zshrc
```

## Commands
```sh
dotnet new console -n [app_name]

dotnet new console -lang "VB" -o [app_name]

dotnet run

dotnet clean
```

## Tree

```text
.
├── api
│   ├── catch.cs
│   ├── console.cs
│   ├── flow.cs
│   ├── mod.cs
│   ├── poo.cs
│   ├── template.cs
│   └── var.cs
├── debug
│   └── debug1
│       ├── debug1.csproj
│       ├── obj
│       │   ├── debug1.csproj.nuget.dgspec.json
│       │   ├── debug1.csproj.nuget.g.props
│       │   ├── debug1.csproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   └── project.nuget.cache
│       └── Program.cs
├── Laboratorio1
│   ├── Laboratorio_1.csproj
│   ├── obj
│   │   ├── Laboratorio_1.csproj.nuget.dgspec.json
│   │   ├── Laboratorio_1.csproj.nuget.g.props
│   │   ├── Laboratorio_1.csproj.nuget.g.targets
│   │   ├── project.assets.json
│   │   ├── project.nuget.cache
│   │   └── Release
│   │       └── net8.0
│   │           ├── Laboratorio_1.AssemblyInfo.cs
│   │           ├── Laboratorio_1.AssemblyInfoInputs.cache
│   │           ├── Laboratorio_1.assets.cache
│   │           ├── Laboratorio_1.GeneratedMSBuildEditorConfig.editorconfig
│   │           └── Laboratorio_1.GlobalUsings.g.cs
│   └── Program.cs
├── Laboratorio10
│   ├── Laboratorio11
│   │   ├── Laboratorio11.vbproj
│   │   ├── obj
│   │   │   ├── Laboratorio11.vbproj.nuget.dgspec.json
│   │   │   ├── Laboratorio11.vbproj.nuget.g.props
│   │   │   ├── Laboratorio11.vbproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.vb
│   ├── Laboratorio12
│   │   ├── Laboratorio12.vbproj
│   │   ├── obj
│   │   │   ├── Laboratorio12.vbproj.nuget.dgspec.json
│   │   │   ├── Laboratorio12.vbproj.nuget.g.props
│   │   │   ├── Laboratorio12.vbproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.vb
│   ├── Laboratorio13
│   │   ├── Laboratorio13.vbproj
│   │   ├── obj
│   │   │   ├── Laboratorio13.vbproj.nuget.dgspec.json
│   │   │   ├── Laboratorio13.vbproj.nuget.g.props
│   │   │   ├── Laboratorio13.vbproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.vb
│   └── Laboratorio14
│       ├── Laboratorio14.vbproj
│       ├── obj
│       │   ├── Laboratorio14.vbproj.nuget.dgspec.json
│       │   ├── Laboratorio14.vbproj.nuget.g.props
│       │   ├── Laboratorio14.vbproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   └── project.nuget.cache
│       ├── Perro.vb
│       └── Program.vb
├── Laboratorio2
│   ├── Laboratorio21
│   │   ├── Laboratorio21.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio21.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio21.csproj.nuget.g.props
│   │   │   ├── Laboratorio21.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio22
│   │   ├── Laboratorio22.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio22.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio22.csproj.nuget.g.props
│   │   │   ├── Laboratorio22.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   └── Laboratorio23
│       ├── Laboratorio23.csproj
│       ├── obj
│       │   ├── Laboratorio23.csproj.nuget.dgspec.json
│       │   ├── Laboratorio23.csproj.nuget.g.props
│       │   ├── Laboratorio23.csproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   └── project.nuget.cache
│       └── Program.cs
├── Laboratorio3
│   ├── Laboratorio31
│   │   ├── Laboratorio31.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio31.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio31.csproj.nuget.g.props
│   │   │   ├── Laboratorio31.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio32
│   │   ├── Laboratorio32.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio32.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio32.csproj.nuget.g.props
│   │   │   ├── Laboratorio32.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio33
│   │   ├── Laboratorio33.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio33.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio33.csproj.nuget.g.props
│   │   │   ├── Laboratorio33.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   └── Laboratorio34
│       ├── Laboratorio34.csproj
│       ├── obj
│       │   ├── Laboratorio34.csproj.nuget.dgspec.json
│       │   ├── Laboratorio34.csproj.nuget.g.props
│       │   ├── Laboratorio34.csproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   └── project.nuget.cache
│       └── Program.cs
├── Laboratorio4
│   ├── Laboratorio41
│   │   ├── Laboratorio41.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio41.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio41.csproj.nuget.g.props
│   │   │   ├── Laboratorio41.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio42
│   │   ├── Laboratorio42.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio42.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio42.csproj.nuget.g.props
│   │   │   ├── Laboratorio42.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio43
│   │   ├── Laboratorio43.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio43.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio43.csproj.nuget.g.props
│   │   │   ├── Laboratorio43.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio44
│   │   ├── Laboratorio44.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio44.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio44.csproj.nuget.g.props
│   │   │   ├── Laboratorio44.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio45
│   │   ├── Laboratorio45.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio45.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio45.csproj.nuget.g.props
│   │   │   ├── Laboratorio45.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio46
│   │   ├── Laboratorio46.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio46.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio46.csproj.nuget.g.props
│   │   │   ├── Laboratorio46.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   └── Laboratorio47
│       ├── Laboratorio47.csproj
│       ├── obj
│       │   ├── Laboratorio47.csproj.nuget.dgspec.json
│       │   ├── Laboratorio47.csproj.nuget.g.props
│       │   ├── Laboratorio47.csproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   └── project.nuget.cache
│       └── Program.cs
├── Laboratorio5
│   ├── Laboratorio51
│   │   ├── Laboratorio51.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio51.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio51.csproj.nuget.g.props
│   │   │   ├── Laboratorio51.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio52
│   │   ├── Laboratorio52.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio52.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio52.csproj.nuget.g.props
│   │   │   ├── Laboratorio52.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio53
│   │   ├── Laboratorio53.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio53.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio53.csproj.nuget.g.props
│   │   │   ├── Laboratorio53.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio54
│   │   ├── Laboratorio54.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio54.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio54.csproj.nuget.g.props
│   │   │   ├── Laboratorio54.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio55
│   │   ├── Laboratorio55.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio55.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio55.csproj.nuget.g.props
│   │   │   ├── Laboratorio55.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   └── Laboratorio56
│       ├── Laboratorio56.csproj
│       ├── obj
│       │   ├── Laboratorio56.csproj.nuget.dgspec.json
│       │   ├── Laboratorio56.csproj.nuget.g.props
│       │   ├── Laboratorio56.csproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   └── project.nuget.cache
│       └── Program.cs
├── Laboratorio6
│   ├── Laboratorio61
│   │   ├── Laboratorio61.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio61.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio61.csproj.nuget.g.props
│   │   │   ├── Laboratorio61.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio62
│   │   ├── Laboratorio62.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio62.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio62.csproj.nuget.g.props
│   │   │   ├── Laboratorio62.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio63
│   │   ├── Laboratorio63.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio63.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio63.csproj.nuget.g.props
│   │   │   ├── Laboratorio63.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   └── Laboratorio64
│       ├── Laboratorio64.csproj
│       ├── obj
│       │   ├── Laboratorio64.csproj.nuget.dgspec.json
│       │   ├── Laboratorio64.csproj.nuget.g.props
│       │   ├── Laboratorio64.csproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   └── project.nuget.cache
│       └── Program.cs
├── Laboratorio7
│   ├── Laboratorio71
│   │   ├── Banco.cs
│   │   ├── Cliente.cs
│   │   ├── Laboratorio71.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio71.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio71.csproj.nuget.g.props
│   │   │   ├── Laboratorio71.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   └── Laboratorio72
│       ├── Dado.cs
│       ├── JuegoDeDados.cs
│       ├── Laboratorio72.csproj
│       ├── obj
│       │   ├── Laboratorio72.csproj.nuget.dgspec.json
│       │   ├── Laboratorio72.csproj.nuget.g.props
│       │   ├── Laboratorio72.csproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   └── project.nuget.cache
│       └── Program.cs
├── Laboratorio8
│   ├── Laboratorio81
│   │   ├── Laboratorio81.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio81.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio81.csproj.nuget.g.props
│   │   │   ├── Laboratorio81.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   ├── Persona.cs
│   │   ├── Program.cs
│   │   └── Trabajador.cs
│   ├── Laboratorio82
│   │   ├── CuentaAhorro.cs
│   │   ├── CuentaCorriente.cs
│   │   ├── Cuenta.cs
│   │   ├── Laboratorio82.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio82.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio82.csproj.nuget.g.props
│   │   │   ├── Laboratorio82.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio83
│   │   ├── Laboratorio83.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio83.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio83.csproj.nuget.g.props
│   │   │   ├── Laboratorio83.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio84
│   │   ├── Cobertura.cs
│   │   ├── CuentaBancaria.cs
│   │   ├── Empleado.cs
│   │   ├── Laboratorio84.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio84.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio84.csproj.nuget.g.props
│   │   │   ├── Laboratorio84.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio85
│   │   ├── Coordenadas.cs
│   │   ├── Laboratorio85.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio85.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio85.csproj.nuget.g.props
│   │   │   ├── Laboratorio85.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio86
│   │   ├── ClaseBase.cs
│   │   ├── Laboratorio86.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio86.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio86.csproj.nuget.g.props
│   │   │   ├── Laboratorio86.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio87
│   │   ├── Laboratorio87.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio87.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio87.csproj.nuget.g.props
│   │   │   ├── Laboratorio87.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio88
│   │   ├── Laboratorio88.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio88.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio88.csproj.nuget.g.props
│   │   │   ├── Laboratorio88.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   └── Laboratorio89
│       ├── Laboratorio89.csproj
│       ├── obj
│       │   ├── Laboratorio89.csproj.nuget.dgspec.json
│       │   ├── Laboratorio89.csproj.nuget.g.props
│       │   ├── Laboratorio89.csproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   └── project.nuget.cache
│       └── Program.cs
├── Laboratorio9
│   ├── Laboratorio91
│   │   ├── Laboratorio91.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio91.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio91.csproj.nuget.g.props
│   │   │   ├── Laboratorio91.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio92
│   │   ├── Laboratorio92.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio92.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio92.csproj.nuget.g.props
│   │   │   ├── Laboratorio92.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio93
│   │   ├── Laboratorio93.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio93.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio93.csproj.nuget.g.props
│   │   │   ├── Laboratorio93.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   ├── Laboratorio94
│   │   ├── Aleatorios.cs
│   │   ├── Laboratorio94.csproj
│   │   ├── obj
│   │   │   ├── Laboratorio94.csproj.nuget.dgspec.json
│   │   │   ├── Laboratorio94.csproj.nuget.g.props
│   │   │   ├── Laboratorio94.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── Program.cs
│   └── Laboratorio95
│       ├── Aleatorios.cs
│       ├── Laboratorio95.csproj
│       ├── obj
│       │   ├── Laboratorio95.csproj.nuget.dgspec.json
│       │   ├── Laboratorio95.csproj.nuget.g.props
│       │   ├── Laboratorio95.csproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   └── project.nuget.cache
│       └── Program.cs
├── makefile
└── README.md

106 directories, 353 files
```
