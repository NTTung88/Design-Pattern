package dp.tdtu;

public class Test {
	RSSService service = new RSSService();
	Client client1 = new Client(service);
	Client client2 = new Client(service);
	//call addPost to test
	Post p1 = new Post(“post 1 title”, “post 1 content”);
	service.addPost(p1);
	Post p2 = new Post(“post 2 title”, “post 2 content”);
	service.addPost(p2);
}
