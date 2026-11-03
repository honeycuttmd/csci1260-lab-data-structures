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

    /// <summary>
    /// Returns the three courses with the highest enrollment, sorted from largest to smallest.
    /// </summary>
    /// <param name="courses">The list of courses to search.</param>
    /// <returns>A list containing the course codes and enrollment counts.</returns>
    public static List<string> TopThreeByEnrollment(List<Course> courses)
    {
        return courses
            .OrderByDescending(c => c.Enrolled)
            .Take(3)
            .Select(c => $"{c.Code} ({c.Enrolled})")
            .ToList();
    }

    /// <summary>
    /// Calculates the total number of students enrolled across all courses.
    /// </summary>
    /// <param name="courses">The list of courses to calculate enrollment from.</param>
    /// <returns>The total number of enrolled students.</returns>
    public static int TotalEnrolled(List<Course> courses)
    {
        return courses.Sum(c => c.Enrolled);
    }

    /// <summary>
    /// Counts the number of courses that have no available seats.
    /// </summary>
    /// <param name="courses">The list of courses to check.</param>
    /// <returns>The number of full courses.</returns>
    public static int FullCourseCount(List<Course> courses)
    {
        return courses.Count(c => c.SeatsLeft == 0);
    }

    /// <summary>
    /// Creates a dictionary that maps each course code to its course.
    /// </summary>
    /// <param name="courses">The list of courses to convert.</param>
    /// <returns>A dictionary of course codes and their associated courses.</returns>
    public static Dictionary<string, Course> ByCode(List<Course> courses)
    {
        return courses.ToDictionary(c => c.Code);
    }

    /// <summary>
    /// Creates a department report sorted by total enrollment from highest to lowest.
    /// </summary>
    /// <param name="courses">The list of courses to summarize.</param>
    /// <returns>A list of department names, course counts, and enrollment totals.</returns>
    public static List<string> DepartmentReport(List<Course> courses)
    {
        return courses
            .GroupBy(c => c.Dept)
            .OrderByDescending(g => g.Sum(c => c.Enrolled))
            .Select(g => $"{g.Key} | courses: {g.Count()} | students: {g.Sum(c => c.Enrolled)}")
            .ToList();
    }
}
