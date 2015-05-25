class: middle, center
# Intro to MongoDB for .NET

    Matthew Nichols
    @mnicholsdevguy
    http://matthew-nichols.com

![MongoDB](images/mongodb-logo-web.png)

https://github.com/MatthewNichols/mongoDB4.NETTalks 
---

# What is MongoDB?
MongoDB is a Document Database.

Cool Picture here 

???
MongoDB is a cross platform, open source, document database.  Obligatory NoSQL mention here. It stores data in collections of JSON-ish documents that can be fully indexed for very fast search.

---

# Benefits and Features:

* Highly scalable and available. 
* Schemaless
???

* Ok there is almost certainly a schema, but it is managed by a the application, not in fixed structures in the database
* Open source and well supported
* Everything is JSON(ish, explain BSON a little bit) but fully indexable
* which brings us to...
* GPL License for MongoDB itself, but C# driver is the liberal Apache 2.
    
--

* Incredibly Productive and Fun for development 
???

* Supports subclassing easily
* No "Object-relational impedance mismatch"; data feels like objects
* Data access is stupidly easy. No ORM needed
* Because the schema is managed by the application a bunch of typical DB problems become very easy to handle...DB version control, schema maintenance in local dbs, deploys, maintaining test data
* LINQ support...though not in the current version of the driver, probably returning in 2.1.

---

# And other nice stuff

* Full text indexes
* Easy to set up highly available replica sets 
* Relatively easy to scale
* Runs on all the major platforms

???
* (Sharding) is relatively easy to set up (though should be done with a degree of care)
* "A replica set in MongoDB is a group of mongod processes that maintain the same data set. Replica sets provide redundancy and high availability...."  
http://docs.mongodb.org/manual/replication/
http://www.mongodb.com/presentations/replication-and-replica-sets-3
* From Raspberry Pi (sort of) to Windows/OSX/Linux to all major cloud providers (http://docs.mongodb.org/ecosystem/platforms/)
---

# Downsides?

* A little learning curve
* No Transactions or DB Joins

???

* A little (re)learning curve for people who have been doing relational for a long time. Frankly for new developers I would say it is much easier than relational.
* Querying outside of application code takes getting used to (just like SQL did, remember?)
* No Joins, No Transactions, No constriants? What????
    * Remember MongoDB assumes multi-instance scaling will be used and these are very expensive operations across instances
    * Doesn't matter as much as you might think 
    * Joins and constraints can be done, but they are done in the application layer and require a round trip.  Caching can be useful here
* Not great tooling out of the box.  But a growing number of third party tools.

---

# Examples/Demos
* Installing
    * Standard installers and install directions for all platforms at http://docs.mongodb.org/manual/
    * Config tips in the Github repos for this talk
* The obligatory Hello World
    * Connecting to MongoDB
* Something a little more useful
    * Inserting
    * Reading/Searching
    * Deleting
* An example of a typical schema
    * Here is why the lack of transactions is rarely that big a deal
    * If you still need transactions take a MongoDB/SQL hybrid approach.  This can also be useful for reporting.
* Indexing
* Mapping
    * Conventions
* Quick examples in one or two other frameworks
    * NodeJs (MEAN stack maybe?)
    * ??

???

---
# Tools
* RoboMongo http://www.robomongo.org/ A "shell-centric cross platform MongoDB Management tool". Open source, getting regular updates.  
.tool-image1[ ![MongoDB](images/robomongo.png)]

---
# Tools
* NoSQL Manager http://www.mongodbmanager.com/  Looks good but I haven't tried yet. Proprietary, but reasonably priced.   
.tool-image2[ ![MongoDB](images/nosql-manager.jpg)]
---
# Tools
* MongoDB's native tools; query shell, import, backup and more.  Very useful but like most power tools have a learning curve.

---
# Tools
* SlamData http://slamdata.com Open source tool for querying MongoDB.
![MongoDB](images/graphic-slamdata-editor-small.png)
---
# Tools
* Other third-party tools
---

# Similar systems
* CouchBase
.tool-image3[ ![CouchBase](images/couchbase.jpg)]
* RavenDB
.tool-image3[ ![RavenDB](images/Ravendb.jpg)]
* Azure DocumentDB
.tool-image3[ ![DocumentDB](images/documentDB.png)]
* PostgreSQL now has JSON datatypes with indexing. 
* MSSQL 2016 getting JSON support with sort-of indexing. (http://i1.blogs.msdn.com/b/jocapc/archive/2015/05/16/json-support-in-sql-server-2016.aspx) 

---

# Learn More
* MongoDB .NET Driver docs (http://mongodb.github.io/mongo-csharp-driver/)
* MongoDB Docs (http://docs.mongodb.org/manual/)
* Stackoverflow (obviously)
* Pluralsight has a large number of courses.
* MongoDB University (https://university.mongodb.com/)
	* MongoDB for .NET Developers
	* MongoDB for Node.js Developers
	* and many more
* Source for this presentation at https://github.com/MatthewNichols/mongoDB4.NETTalks

---
class: middle, center
# Intro to MongoDB for .NET

    Matthew Nichols
    @mnicholsdevguy
    http://matthew-nichols.com

![MongoDB](images/mongodb-logo-web.png)



https://github.com/MatthewNichols/mongoDB4.NETTalks 