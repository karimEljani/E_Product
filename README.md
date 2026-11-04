# TP N°2 – Gestion des articles (ASP.NET Core MVC + EF Core Code First)

## Prérequis
- Visual Studio 2022 (charge de travail ASP.NET) + SQL Server LocalDB
- .NET 8 SDK (pour .NET 6 : changer `TargetFramework` en `net6.0` et les packages EF en `6.0.x`)

## Mise en route
1. Ouvrir le dossier / `TP_Product.csproj` dans Visual Studio (restauration NuGet automatique).
2. Outils > Gestionnaire de package NuGet > Console du Gestionnaire de package :

       PM> Add-Migration InitialCreate
       PM> Update-Database

   (la base `MyBaseDB` avec les tables `Categories` et `Products` est créée)
3. Lancer (F5). Créer d'abord quelques **catégories** (menu « Catégories »), puis des **articles**
   (menu « Liste d'articles » > « Nouvel Article »).

En ligne de commande : `dotnet tool install --global dotnet-ef`, puis
`dotnet ef migrations add InitialCreate` et `dotnet ef database update`.

## Contenu
- Models : Product, Category, AppDbContext, Repositories (interfaces + implémentations)
- ViewModels : CreateViewModel, EditViewModel (upload d'image via IFormFile)
- Controllers : ProductController (CRUD + Search + upload), CategoryController (CRUD)
- Views : Index (card-group), Create, Edit, Details, Delete pour Product et Category
- Navbar « Liste d'articles » + recherche par nom d'article ou de catégorie
- wwwroot/images : dossier de stockage des images (noimage.jpg par défaut)
