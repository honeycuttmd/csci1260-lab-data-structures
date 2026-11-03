/// <summary>
/// Provides a fair office hours schedule using a queue of student visits.
/// </summary>
public static class OfficeHours
{
    /// <summary>
    /// Processes student visits in turns until every student has finished.
    /// </summary>
    /// <param name="line">The queue of students waiting for help.</param>
    /// <param name="slice">The max number of minutes allowed per turn.</param>
    /// <returns>A list of students and their completion times.</returns>
    public static MyList<string> Run(MyQueue<Visit> line, int slice)
    {
        MyList<string> results = new MyList<string>();
        int clock = 0;

        while (!line.IsEmpty)
        {
            Visit student = line.Dequeue();

            clock += student.Help(slice);

            if (student.MinutesLeft > 0)
            {
                line.Enqueue(student);
            }
            else
            {
                results.Add($"{student.Name} done at minute {clock}");
            }
        }

        return results;
    }
}
