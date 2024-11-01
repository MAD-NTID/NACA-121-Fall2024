// Stack<int> stack = new Stack<int>(10000);

// for(int i = 5; i >=1; i--) {
//     Console.WriteLine($"Adding {i} to the stack" );
//     stack.Push(i);
// }


// Console.WriteLine("\nRemoving the elements from the stack\n\n");
// for(int i = 1; i <= 5; i++) {
//     Console.WriteLine(stack.Pop());
// }

string filename = "movies.txt";

IPlayListMedia<Video> playListQueue = new PlayListMediaQueue<Video>();

IPlayListMedia<Video> playListStack = new PlayListMediaStack<Video>();

StreamReader reader = new StreamReader(filename);
bool skipHeader = true;

while(!reader.EndOfStream) {
    string[] fields = reader.ReadLine().Split(",");
    if(skipHeader) {
        skipHeader = false;
        continue;
    }

    string title = fields[0];
    string duration = fields[1];
    string category = fields[2];

    Video video = new Video(title, duration, category);

    Console.WriteLine($"Adding the {video} to the queue");
    playListQueue.Add(video);
    Console.WriteLine($"Adding the {video} to the stack");
    playListStack.Add(video);
}

reader.Close();

Console.WriteLine("All videos are loaded in the stack and queue");
Console.WriteLine($"StackPlaylist:{playListStack}");
Console.WriteLine($"QueuePlaylist:{playListQueue}");