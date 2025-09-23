# DS4

dotnet run

dotnet clean

dotnet new console -n [app_name]

## Template

```cs
internal class Program {
    private static void Main(string[] args) {

    }
}

public class MyClass {

}
```

## Tree

```text
.
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
├── makefile
└── README.md

49 directories, 154 files
```
