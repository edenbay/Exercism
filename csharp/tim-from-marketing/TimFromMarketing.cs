using System;

static class Badge
{
    public static string Print(int? id, string name, string? department) 
        {
            string empID = (id != null ? $"[{id}] - " : ""); 
            string empDepartment = (department != null ? $" - {department.ToUpper()}" : " - OWNER");

            return $"{empID}{name}{empDepartment}";
        } 
}