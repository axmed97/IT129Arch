﻿using Core.Entities.Abstract;
using Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;
public class CategoryLanguage : BaseEntity
{
    public string Name { get; set; }
    public string LangCode { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
