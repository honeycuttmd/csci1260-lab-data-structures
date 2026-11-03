/// <summary>
/// Stores course titles and allows them to be looked up by course code.
/// </summary>
public class CourseCatalog
{
    private Dictionary<string, string> courses = new Dictionary<string, string>();

    public int Count => courses.Count;

    /// <summary>
    /// Adds a course to the catalog if its code does not already exist.
    /// </summary>
    /// <param name="code">The course code.</param>
    /// <param name="title">The course title.</param>
    /// <returns>True if the course was added; otherwise, false.</returns>
    public bool AddCourse(string code, string title)
    {
        return courses.TryAdd(code, title);
    }

    /// <summary>
    /// Shows the title associated with a course code.
    /// </summary>
    /// <param name="code">The course code to look up.</param>
    /// <returns>The course title, or a message if the code is not found.</returns>
    public string TitleFor(string code)
    {
        if (courses.TryGetValue(code, out string? title))
        {
            return title;
        }

        return "(no such course)";
    }
}
