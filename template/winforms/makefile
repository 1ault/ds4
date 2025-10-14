all:
	pwd
	cd ./../ && pwd

dotrun:
	cd ./../ && dotnet run

mono:
	cd ./../ && mcs -r:System.Windows.Forms -r:System.Drawing -out:CrossApp.exe Program.cs Form1.cs
	cd ./../ && mono CrossApp.exe

net:
	cd ./../ && dotnet build -f net8.0
	cd ./../ && wine dotnet bin/Debug/net8.0/CrossApp.dll

clean:
	cd ./../ && dotnet clean && rm -rf bin obj


wifi:
	sudo ifconfig wlan0 down
	sudo ifconfig wlan0 up
	sudo dhclient wlan0

