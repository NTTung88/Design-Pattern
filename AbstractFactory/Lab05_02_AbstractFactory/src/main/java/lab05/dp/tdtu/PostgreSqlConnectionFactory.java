package lab05.dp.tdtu;

import lab05.dp.tdtu.Connection;
import lab05.dp.tdtu.PostgreSqlConnection;

public class PostgreSqlConnectionFactory implements ConnectionFactory {


  public Connection getConnection() {
    return new PostgreSqlConnection();
  }

}
