# Inl-mningsuppgift1.ASP

ASP.NET Core och dess användningsområde.

ASP.NET Core är framtaget av microsoft och har gjort det till en cross-plattform med open-source framework med öppen källkod för att bygga moderna och internetanslutna appar. Det funkar på olika operativsystem så som Linux, macOS och Windows.

WWWroot (web root), den innehåller statiska filer, så som HTML, CSS, images och JavaScript.

Startup.
Startup klassen anges när host håller på att byggast. Startup klassen specificeras vanligtvis via att anropa på WebHostBuilderExtensions.UseStartup <TStartup> -metoden.

Razor Pages
Det är ett projekt-template i ASP.NET Core som gör det enklare att skapa webbsidor. När man ha skapat ett Razor pages projekt i tex VS så få man med olika färdiga mappar som innehåller filer som är en liten del av grunstrukturen.
den innehåller bla WWWroot och startup som nämns ovan. man få även med mappen Pages som innehåller .cshtml - filer som då även kallas content page och man få med .cshtml.cs - filer som kallas page model.
Razor- språket som används i ASP.NET Core är en kombination av C# och HTML.

MVC = Model-View-Controller

Model
Model-klassernas skapas, som vi sedan fyller med properties över vad vi ska lagra för data . Den hantera även regler och logik för hur applikationen ska fungera

View
View är ansvariga för att presentera innehåll via användargränssnittet. De använder Razor-visningsmotorn för att bädda in .NET-kod i HTML-markering.

Controller
tar emot olika request från webbsidans View som sedan gör någonting med inputen eller så skickar den bara vidaren den till Model. Man kan säga att det är en kommunikationskanal mellan Model och View.
