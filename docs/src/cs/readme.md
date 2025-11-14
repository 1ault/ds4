# CS C#

## Install

### Linux

**bash**
```sh
wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
chmod +x dotnet-install.sh

./dotnet-install.sh --channel 8.0 --install-dir $HOME/.dotnet
```

**zshrc**
```sh
echo 'export DOTNET_ROOT=$HOME/.dotnet' >> ~/.zshrc
echo 'export PATH=$DOTNET_ROOT:$PATH' >> ~/.zshrc
echo 'export DOTNET_CLI_TELEMETRY_OPTOUT=1' >> ~/.zshrc
source ~/.zshrc
```

### Windows

[visualstudio](https://visualstudio.microsoft.com/es/downloads/)

[.dotnet](https://dotnet.microsoft.com/en-us/download)


## Config

**Git**
```sh
git config --global core.autocrlf input
git config --global core.eol lf
```

## Commands

**Basic**
```sh
dotnet run
dotnet clean
```

**Templates**
```sh
dotnet new console -n <([app_name])>
dotnet new winforms -n <([app_name])>
```
