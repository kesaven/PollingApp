using SQLite;
using System;
using System.IO;
using System.Threading.Tasks;
using PollingApp;
using Xamarin.Essentials;

namespace PollingApp
{
	public class LocalDatabase : IDatabase
	{
		private const string DatabaseName = "polls.db3";

		private readonly Task initializedTask;

		private SQLiteAsyncConnection connection;

		public LocalDatabase()
		{
			initializedTask = Task.Run(async () =>
			{
				var databasePath = Path.Combine(FileSystem.AppDataDirectory, DatabaseName);
				connection = new SQLiteAsyncConnection(databasePath);

				await connection.CreateTableAsync<Polls>();
				
			});
		}

	}

    public class Polls
    {

    }
}
