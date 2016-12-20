$connectionString = $OctopusParameters["DatabaseConnectionString"]

.\migrate.exe SimpleMVCApp.Data.dll /connectionString="$($connectionString)" /connectionProviderName="System.Data.SqlClient"