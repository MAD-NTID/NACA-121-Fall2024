public class Printer<T>
{
    private T[] jobs;
    private int size, front;

    public Printer(int capacity)
    {
        this.jobs = new T[capacity];
        this.front = size = 0;
    }

    public bool Add(T job)
    {
        //is the array full?
        if(this.size == this.jobs.Length)
            return false;
        //add the job to the queue
        jobs[size] = job;
        size++; //increase the size
        return true;
    }

    public T Print()
    {
        if(size < 0){
            return default;
        }
        //get the element at the front
        T element = this.jobs[front];
        this.jobs[front] = default;
        this.size--;
        this.front++;
        //return the element
        return element;
    }

    public bool Cancel(T job)
    {
        for(int i = 0; i < jobs.Length; i++){
            T element = this.jobs[i];

            //class1Obj.Equals(class2Obj);

            bool match = EqualityComparer<T>.Default.Equals(element,job);
            if(match) {
                this.jobs[i] = default;
                size--;
                return true;
            }
            
        }

        return false;
    }

}