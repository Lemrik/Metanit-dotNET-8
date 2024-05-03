// В файле проекта можно подключить или отключить пространства имен по уполчанию
// Кликаем на файл проекта и ищем строку:

/*
    <ImplicitUsings>enable</ImplicitUsings> - включено 
    <ImplicitUsings>disable</ImplicitUsings> - отключено

    Вместо подключения по умолчанию некоторого набора пространств имен по умолчанию
    также можно подключать и отключать по отдельности пространств имен.

    <Project Sdk="Microsoft.NET.Sdk">
 
      <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net6.0</TargetFramework>
        <ImplicitUsings>disable</ImplicitUsings>
        <Nullable>enable</Nullable>
      </PropertyGroup>
   
      <ItemGroup>
        <Using Include="System" />
        <Using Include="System.Threading.Tasks" />
      </ItemGroup>
   
    </Project>


    либо отключить:

    <ItemGroup>
        <Using Remove="System" />
        <Using Remove="System.Threading.Tasks"/>
    </ItemGroup>
 
 */