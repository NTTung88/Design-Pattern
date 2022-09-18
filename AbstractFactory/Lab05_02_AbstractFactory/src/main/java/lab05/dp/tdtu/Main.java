package lab05.dp.tdtu;

import lab05.dp.tdtu.Application;
import lab05.dp.tdtu.ConnectionFactory;
import lab05.dp.tdtu.MySqlConnectionFactory;
import lab05.dp.tdtu.PostgreSqlConnectionFactory;

public class Main {

  public static void main(String[] args) {

    // We should fetch the database type from an
    // external resource (ex: configuration file).
    // In order to keep this example simple we will
    // use a private static method and an Enum
    DatabaseType databaseType = DatabaseType.MYSQL;
    ConnectionFactory connectionFactory = 
             getConnectionFactory(databaseType);

    Application application = new Application(connectionFactory);
    application.start();
  }

  private static ConnectionFactory getConnectionFactory(
      DatabaseType databaseType) {
    switch (databaseType) {
    case MYSQL:
      return new MySqlConnectionFactory();
    default:
      return new PostgreSqlConnectionFactory();
    }
  }

  private enum DatabaseType {
    MYSQL, POSTGRE;
  }

}