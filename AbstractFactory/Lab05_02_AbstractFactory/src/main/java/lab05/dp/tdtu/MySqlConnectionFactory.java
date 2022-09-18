package lab05.dp.tdtu;

import lab05.dp.tdtu.Connection;
import lab05.dp.tdtu.MySqlConnection;

public class MySqlConnectionFactory implements ConnectionFactory {


  public Connection getConnection() {
    return new MySqlConnection();
  }

}