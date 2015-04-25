# Intro to MongoDB for .NET 
* What is MongoDB?
    * A document database, what's that?...explain basic structures; collections, documents, indexes
* Benefits and Features:
	* Highly scalable and available. Built to scale horizontally and to replicate
    * Schemaless and Multi-dimensional
	    * Ok there is almost certainly a schema, but it is managed by a the application, not in fixed structures in the database
	    * Open source and well supported
	    * Everything is JSON(ish, explain BSON a little bit) but fully indexable
	    * which brings us to...
    * Incredibly Productive for development 
	    * Supports subclassing easily
	    * No "Object-relational impedance mismatch"; data feels like objects
	    * Data access is stupidly easy. No ORM needed
	    * Because the schema is managed by the application a bunch of typical DB problems become very easy to handle...DB version control, schema maintenance in local dbs, deploys, maintaining test data
	    * LINQ support...though not in the current version of the driver, probably returning in 2.1.
    * Full text indexes
    * Easy to set up highly available ReplicaSets
* Downsides?
    * A little (re)learning curve for people who have been doing relational for a long time. Frankly for new developers I would say it is much easier than relational.
    * Feature vs Scalability chart?
    * No Joins, No Transactions, No constriants? What????
        * Remember MongoDB assumes multi-instance scaling will be used and these are very expensive operations across instances
        * Doesn't matter as much as you might think 
        * Joins and constraints can be done, but they are done in the application layer and require a round trip.  Caching can be useful here
    * Not great tooling out of the box.  But a growing number of third party tools.
    * Querying outside of application code takes getting used to (just like SQL did, remember?)
* Examples/Demo
    * Installing
        * Config file
        * Setting up as a service
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
* Resources
	* Tools
		* RoboMongo http://www.robomongo.org/ A "shell-centric cross platform MongoDB Management tool" 
		* MongoDB's native tools; query shell, import, backup and more
		* SlamData http://slamdata.com Open source tool for querying MongoDB.
		* Other third-party tools
		* Rumors of MongoDB building a Visual Studio query tool
	* Similar systems
		* CouchBase
		* RavenDB
		* Microsoft DocumentDB
		* PostgreSQL now has JSON datatypes with indexing. 
	* Learn More
		* Stackoverflow (obviously)
		* Pluralsight has a large number of courses.
	    * MongoDB University (https://university.mongodb.com/)
	        * MongoDB for .NET Developers
	        * MongoDB for Node.js Developers
	        * and many more