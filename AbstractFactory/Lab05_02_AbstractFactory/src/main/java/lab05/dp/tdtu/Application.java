package lab05.dp.tdtu;

import lab05.dp.tdtu.Connection;
import lab05.dp.tdtu.ConnectionFactory;

public class Application {

  private final ConnectionFactory connectionFactory;

  public Application(ConnectionFactory connectionFactory) {
    this.connectionFactory = connectionFactory;
  }

  public void start() {
    Connection connection = connectionFactory.getConnection();
    connection.connect();
    // proceed with application execution...
  }

}