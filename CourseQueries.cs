/// <summary>
/// Provides LINQ queries for filtering, sorting, and summarizing courses.
/// </summary>
public static class CourseQueries
{
    /// <summary>
    /// Returns the codes of courses that have at least one available seat.
    /// </summary>
    /// <param name="courses">The list of courses to search.</param>
    /// <returns>A list of course codes with available seats.</returns>
    public static List<string> OpenCourseCodes(List<Course> courses)
    {
        return courses
            .Where(c => c.SeatsLeft > 0)
            .Select(c => c.Code)
            .ToList();
    }

    /// <summary>
    /// Finds the titles of courses worth four credit hours.
    /// </summary>
    /// <param name="courses">The list of courses to search.</param>
    /// <returns>A list of four-credit course titles.</returns>
    public static List<string> FourCreditTitles(List<Course> courses)
    {
        return courses
            .Where(c => c.Credits == 4)
            .Select(c => c.Title)
            .ToList();
    }

    /// <summary>
    /// Creates a report showing the available seats for each open course.
    /// </summary>
    /// <param name="courses">The list of courses to search.</param>
    /// <returns>A list of course codes and their available seat counts.</returns>
    public static List<string> SeatsLeftReport(List<Course> courses)
    {
        return courses
            .Where(c => c.SeatsLeft > 0)
            .Select(c => $"{c.Code}: {c.SeatsLeft} seats left")
            .ToList();
    }

    // Part H, demo: the three biggest courses, largest first,
    // like "ENGL 1010 (150)".
    public static List<string> TopThreeByEnrollment(List<Course> courses)
    {
        // TODO: Part H, demo
        throw new NotImplementedException();
    }

    // Part H, demo: every student in every course, added up.
    public static int TotalEnrolled(List<Course> courses)
    {
        // TODO: Part H, demo
        throw new NotImplementedException();
    }

    // Part H, demo: how many courses have no seats left.
    public static int FullCourseCount(List<Course> courses)
    {
        // TODO: Part H, demo
        throw new NotImplementedException();
    }

    // Part H, demo: a dictionary from course code to course, in one line.
    public static Dictionary<string, Course> ByCode(List<Course> courses)
    {
        // TODO: Part H, demo
        throw new NotImplementedException();
    }

    // Exercise 8: one line per department, most students first,
    // like "ENGL | courses: 2 | students: 246".
    public static List<string> DepartmentReport(List<Course> courses)
    {
        // TODO: Part H, Exercise 8
        throw new NotImplementedException();
    }
}
