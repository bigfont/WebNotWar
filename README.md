This is an extremely minimal deployment of an ASP.NET Core rc1 app to an Azure Web App. The vital files are:

    app/
        wwwroot/
            web.config
        project.json
        startup.cs
    .deployment

Ignore the `deploy` directory. It contains an Azure CLI deployment template.
