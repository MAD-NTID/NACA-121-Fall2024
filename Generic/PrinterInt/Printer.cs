public class Printer
{
    private int[] jobs;
    private int size, front;

    public Printer(int capacity)
    {
        this.jobs = new int[capacity];
        this.front = size = 0;
    }

    public bool Add(int job)
    {
        //is the array full?
        if(this.size == this.jobs.Length)
            return false;
        //add the job to the queue
        jobs[size] = job;
        size++; //increase the size
        return true;
    }

    public int Print()
    {
        //get the element at the front
        int element = this.jobs[front];
        this.jobs[front] = -1;
        this.size--;
        this.front++;
        //return the element
        return element;
    }

    public bool Cancel(int job)
    {
        for(int i = 0; i < jobs.Length; i++){
            if(jobs[i] == job) {
                jobs[i] = -1;
                size--;
                return true;
            }
        }

        return false;
    }

}