# GraphQLHotChocolate

#Get List

query{
    employees{
        id,
        name,
        designation
    }
}



#GetById

query{
    get(getByIdVM:{
        id:1
    }){
        id,
        name,
        designation
    }
}

#Create
mutation{
    create(employee:{
        id:214,
        name:"Ömer furkan",
        designation:"Engineer"
    }){
        id,
        name
    }
}

#Delete
mutation{
    delete(deleteVM:{
        id:10
    })
}

