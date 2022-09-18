package lab05.dp.tdtu;

import lab05.dp.tdtu.Computer;

public class ComputerFactory {

	public static Computer getComputer(ComputerAbstractFactory factory){
		return factory.createComputer();
	}
}
