﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevonDev.Controllers
{
    public class CourseController : ApiController
    {
        public CourseController()
        {
        }

        // GET api/Course
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Course/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Course
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Course/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Course/5
        public void Delete(int id)
        {
        }
    }
}