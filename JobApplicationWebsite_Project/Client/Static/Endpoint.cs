using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationWebsite_Project.Client.Static
{
    public static class Endpoint
    {
        public static readonly string Prefix = "api";

        public static readonly string CompanyEndpoint = $"{Prefix}/companys";
        public static readonly string IndivSkillsEndpoint = $"{Prefix}/indivskills";
        public static readonly string JobAppEndpoint = $"{Prefix}/jobapps";
        public static readonly string JobPostingEndpoint = $"{Prefix}/jobpostings";
        public static readonly string ResumeEndpoint = $"{Prefix}/resumes";
        public static readonly string ReviewEndpoint = $"{Prefix}/reviews";
        public static readonly string UsersEndpoint = $"{Prefix}/users";
        public static readonly string SkillSetEndpoint = $"{Prefix}/skillsets";
    }
}
