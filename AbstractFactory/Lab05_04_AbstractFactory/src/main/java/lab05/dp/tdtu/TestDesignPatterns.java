package lab05.dp.tdtu;

import lab05.dp.tdtu.PCFactory;
import lab05.dp.tdtu.ServerFactory;
import lab05.dp.tdtu.ComputerFactory;
import lab05.dp.tdtu.Computer;

public class TestDesignPatterns {

	public static void main(String[] args) {
		testAbstractFactory();
	}

	private static void testAbstractFactory() {
		Computer pc = com.journaldev.design.abstractfactory.ComputerFactory.getComputer(new PCFactory("2 GB","500 GB","2.4 GHz"));
		Computer server = com.journaldev.design.abstractfactory.ComputerFactory.getComputer(new ServerFactory("16 GB","1 TB","2.9 GHz"));
		System.out.println("AbstractFactory PC Config::"+pc);
		System.out.println("AbstractFactory Server Config::"+server);
	}
}