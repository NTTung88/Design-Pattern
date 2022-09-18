package dp.tdtu;

import java.util.ArrayList;
import java.util.Date;

public class RSSService {
	private Date lastUpdate;
	private ArrayList<Post> posts;
	public ArrayList<Post> getPost() {
		return this.posts;
	}
	public RSSService() {
	posts = new ArrayList<Post>();
	lastUpdate = new Date();
	}
	public void addPost(Post p){
	posts.add(p);
	lastUpdate = new Date();
	}
	public Boolean hasNewPost(Date dt){
	if(lastUpdate.compareTo(dt) > 0){
	//lastUpdate is after lastPull
	return true;
	}
	return false;
	}
}