using TwitterClone.Domain.Entities;

//var notification = new Notification(Guid.NewGuid(),"Joy commented on your post","Comment");
//var message=notification.Message;
//Console.WriteLine(message);

var likeNotification = new LikeNotification(Guid.NewGuid(), Guid.NewGuid(),"like Nofication");
var commentNotification = new CommentNotification(Guid.NewGuid(), Guid.NewGuid(),"comment Nofication");
var frNotification = new FriendRequestNotification(Guid.NewGuid(), Guid.NewGuid(),"fr Nofication");
var mNotification = new MentionNotification(Guid.NewGuid(), Guid.NewGuid(),"mention Nofication");
//Guid userId, Guid likeByUserId, string message


Console.WriteLine(likeNotification.GetMessage());
Console.WriteLine(commentNotification.GetMessage());
Console.WriteLine(frNotification.GetMessage());
Console.WriteLine(mNotification.GetMessage());