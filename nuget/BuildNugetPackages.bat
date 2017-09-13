set PKG_VER=2017.1.5
nuget pack ../DataConversionExtensions/DataConversionExtensions.nuspec  -Prop Configuration=Release -Version %PKG_VER%  -o  ../../NugetPackages
pause