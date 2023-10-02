
using hm8_task2;

Worker[] workers = new Worker[]
{
    new President(),
    new Manager(),
    new Security(),
    new Engineer(),
};

foreach (Worker worker in workers)
{
    worker.Print();
}