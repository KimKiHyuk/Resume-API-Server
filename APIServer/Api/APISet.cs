namespace APIServer.API {
    public static class APISet {
        public static string BACKEND_ROOT => "https://resume-admin.herokuapp.com/";
        public static string BACKEND_API_ROOT => BACKEND_ROOT + "api/";
        public static string BACKEND_API_ABOUTME => BACKEND_API_ROOT + "aboutme";
        public static string BACKEND_API_CAREER => BACKEND_API_ROOT + "career";
        public static string BACKEND_API_EDUCATION => BACKEND_API_ROOT + "education";
        public static string BACKEND_API_PROJECT => BACKEND_API_ROOT + "project";
        public static string BACKEND_API_SKILL => BACKEND_API_ROOT + "skill";
        public static string FRONTEND_ROOT => "https://vuetiful-resume.herokuapp.com/";
        public static string FRONTEND_ABOUTME => FRONTEND_ROOT + "aboutme/";
        public static string FRONTEND_CAREER => FRONTEND_ROOT + "career/";
        public static string FRONTEND_EDUCATION => FRONTEND_ROOT + "education/";
        public static string FRONTEND_PROJECT => FRONTEND_ROOT + "project/";
        public static string FRONTEND_SKILL => FRONTEND_ROOT + "skill/";    
    }
}