// Setup
var collection = {
  2548: {
    album: "Slippery When Wet",
    artist: "Bon Jovi",
    tracks: [
      "Let It Rock",
      "You Give Love a Bad Name"
    ]
  },
  2468: {
    album: "1999",
    artist: "Prince",
    tracks: [
      "1999",
      "Little Red Corvette"
    ]
  },
  1245: {
    artist: "Robert Palmer",
    tracks: [ ]
  },
  5439: {
    album: "ABBA Gold"
  }
};

// Only change code below this line
function updateRecords(id, prop, value) {

if(prop != "tracks" && value != ""){
  collection[id][prop] = value;
}
if(prop == "tracks"){
  if(!collection[id].hasOwnProperty(prop)){
    //create an empty array and add new value in
    collection[id].tracks = [value];
 //   console.log(collection[id].tracks);
}else{
  collection[id].tracks.push(value);
 // console.log(collection[id].tracks);
}}
if(value == ""){
  console.log("before" + collection[id][prop]);
  delete collection[id][prop];
  console.log("after" + collection[id][prop]);
}

  return collection;
}

// Alter values below to test your code
updateRecords(5439, "artist", "ABBA");
