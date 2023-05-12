# How to use the windows form
As you will be seen, the form already includes a simple step by step guide on how to use it. This is a more detailed preview:
* The first thing you will see are 2 empty text boxes, enter the number of processes that you will have running, and the number of the resources that will be used, then press the button that creates the table

* You will now have four Tables that you need to input values into, simply click the cell and write down the numbers, The Tables include
    * Total resources: how many instants are there in total for each resource
    * Available resources: how many instance of each resource is available
    * Maximum need: how many instances of each resource would every process need in the worst case scenario
    * Current allocation: how many instances of each resource are the processes using

* Once you've filled in the values of all the tables you will now see three text boxes where you will enter the details about the process you need to add resources to:
    * The number of the process
    * The Letter of the Resource's name
    * How many instances do you need from that resource

    Note: you will enter the new total value of this cell, not just the number of resources that will be added
    
* You will then click on the button which says "check if safe", after you click it the algorithm will take place and you will be sent a message that said whether it's safe or not and whether permission has been granted for you to add the resources you requested  for the process

# How the Code works

## Make table button

### This button takes the number of processes and resources you entered and creates four tables accordingly

* Total recources table: 
    * Rows and columns cleared
    * Ascii variable is initialized at 65 which is the decimal ascii for 'A' so that when a new column is added the header value is incremented and called 'B' and so on..
    * Extra Column is added for the headers of the Rows
    * In a for loop, the headers are added using the ascii  number as mentioned above
    * The extra column mentioned above will be labelled as "Num." as in number of resource istances

* Available resources table: made in the same fashion as total resources table

* Maximum need table: made in almost the same fashion, however more rows are needed and they are labeled as P n where n is the number of process 

* Current Allocation table: made in the same fashion as maximum need table

## Check if safe button
### This button takes the values from the table that you just entered to put them in multiple 2D arrays and calculates the algorithms using these arrays
* All tables are converted into 2D arrays using for loops to transfer the values (headers are not included in the 2D array)


* The values that the user entered  (concering the process that needs more resources) will be used to update the "currently allocated" array

* A new table called the remaining table will be made by calculating the difference btween the maxim cell and the currenly allocated cell

## Checking if it's safe:
* A bool variable is made which will be the one to specify if it's safe or not
* A new array is made called "work", we will copy the values of the "available" array onto it so we can work with it and update it without losing any data

* A new boolean array will be made, size of the array will be equal to the number of the processes, each index in this array will present a 1 or 0 (true or false), showing whether or not the values of the instances of resources in this process has been "released" and added to the "work"(aka available) array. This boolean array will be used in the end to see whather we have reached a point where we've concluded that it's safe or not
* we will then start a while loop that checks for all the rows of the processes to see if any has needed (remaining) resources which is available in the "available" resources, if so we will consider that this process is not executed and released and the resources will go back to the "available" resources (in the "work") array so that they can be used by other processes that need them
* The process will be repeated until we reach a point where either all processes are able to take their needed resources, execute and release them (which will then deem the adding of new resources to the process we previously specified as "safe"), or whether the processes do not have available resources for them to all be  able to take them to execute and release, which will be deemed as "unsafe"
* Using this method, we avoided a deadlock from happening 
