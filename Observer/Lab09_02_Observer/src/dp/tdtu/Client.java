package dp.tdtu;

import java.util.Date;
import java.util.Timer;
import java.util.TimerTask;

public class Client {
	private interval = 5000;//5 seconds
	private Timer timer;
	private RSSService service;
	private Date lastPull;
	public Client(RSSService service) {
	this.service = service;
	lastPull = new Date();
	timer = new Timer();
	timer.schedule(new FetchTask(),interval);
	}
	public class FetchTask
	extends TimerTask {
	public void run() {
	if(service.hasNewPost(
	lastPull)) {
	posts = service.getPosts();
	lastPull = new Date();
	refreshGUI(posts);
	}
	}
	}
	...
	public void refreshGUI(...) {
	//do some stuff to update GUI

	...
	}
}
