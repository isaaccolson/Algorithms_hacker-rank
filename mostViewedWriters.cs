int[][][] mostViewedWriters(int[][] topicIds, int[][] answerIds, int[][] views) {

//1. Extract the unique topicIds

    int[] uniqueTopicIds = abstractTopicIds(topicIds);

    foreach(int id in uniqueTopicIds){
      //  Console.WriteLine("id: " + id);
    }

//2. Create the return int[][][]

    int[][][] mostViewedWritersArray = new int[uniqueTopicIds.Length][][];

//3. Loop through each mostViewedWritersArray adding the sorted data

    for(var i = 0; i < mostViewedWritersArray.Length; i++){

//3A. Get an array of all the Questions linked to the specific Topic

    var currentUniqueId = uniqueTopicIds[i];

    int[] topicIdQuestionsAnswers = GetQuestionsLinkedWithId(currentUniqueId,topicIds);

         foreach(int question in topicIdQuestionsAnswers){
    //    Console.WriteLine("question: " + question);
    }

//3B. Get Answers ids from questions

        int[] answerIdForTopic = GetAnswerIds(topicIdQuestionsAnswers, answerIds);

 //3C. Get List of views for all answersFromViewIds. List so can edit them

    var viewList = new List<int[]>();

    viewList = ViewList(answerIdForTopic, views);

//3D. Sort and shorten list and make it into a int[][]

    var jaggedArray = SortShorten(viewList);

    mostViewedWritersArray[i] = jaggedArray;
    }


    //N. Retun the array
    return mostViewedWritersArray;
}

public int[][] SortShorten(List<int[]> _viewList){

    //1. combine like users in list
    for(var i = 0; i < _viewList.Count; i++){
        var userId = _viewList[i][0];
        for(var j = i + 1; j < _viewList.Count; j++){
            if(_viewList[j][0] == userId){
                _viewList[i][1] += _viewList[j][1];//may be wrong...
                _viewList.RemoveAt(j);
                break;
            }
        }
    }

    //2. sort the list based on views then unser ids
    //go one at a time finding highest then store it. if a tie lower userid breaks tie

    for(var i = 0; i < _viewList.Count; i++){

        var currentHighest = _viewList[i];//can swap with this later if needbe

        for(var j = i + 1; j < _viewList.Count; j++){

            if(_viewList[j][1] > currentHighest[1] || ((_viewList[j][1] == currentHighest[1] && _viewList[j][0] < currentHighest[0]))){
                var newHighest = _viewList[j];
                _viewList[j] = currentHighest;
                currentHighest = newHighest;
            }
        }

        _viewList[i] = currentHighest;

    }

    //checks if more than 10 users


      if(_viewList.Count > 10 && _viewList.Any()){
        for(var i = 0; i < (_viewList.Count - 10); i++){
            _viewList.RemoveAt(_viewList.Count - 1);
        }
    }


    //3. Turn into array

       var sortShorten = new int[_viewList.Count][];



    for(var i = 0; i < sortShorten.Length; i ++){
        sortShorten[i] = _viewList[i];
    }


    return sortShorten;
}

public int[] GetAnswerIds(int[] questions, int[][] _answerIds){

    var listOfAnswerIds = new List<int>();

    for(var i = 0; i < questions.Length; i++){
        for(var j = 0; j < _answerIds[questions[i]].Length; j++){

            listOfAnswerIds.Add(_answerIds[questions[i]][j]);
        }
        }
    var returnArray = new int[listOfAnswerIds.Count];
    for(var i = 0; i < returnArray.Length; i++){
        returnArray[i] = listOfAnswerIds[i];
    //    Console.WriteLine("List of answer id: " + returnArray[i]);
    }

    return returnArray;
}

public List<int[]> ViewList(int[] _questions, int[][] _views){

    var ListToReturn = new List<int[]>();
    for(var i = 0; i < _questions.Length; i++){
        for(var j =0; j < _views.Length; j++){
            if(_questions[i] == _views[j][0]){
             var userIdAnswer = new int[2];
                userIdAnswer[0] = _views[j][1];//user id
                userIdAnswer[1] = _views[j][2];//answer view count
                ListToReturn.Add(userIdAnswer);
        //        Console.WriteLine("UserId: " + userIdAnswer[0] + " View Count: " + userIdAnswer[1]);
            }
        }
    }

    return ListToReturn;

}

public int[] GetQuestionsLinkedWithId(int _id, int[][] _topicIds){

    var questions = new List<int>();

    for(var i = 0; i < _topicIds.Length; i++){
          if(Array.IndexOf(_topicIds[i], _id) != -1){
                questions.Add(i);
    }
    }
        var returnArray = new int[questions.Count];
        for(var j = 0; j < returnArray.Length; j++){
            returnArray[j] = questions[j];
        }

    return returnArray;

}

public int[] abstractTopicIds(int[][] _topicIds){

    var uniqueIds = new List<int>();

    for(var i = 0; i < _topicIds.Length; i++){

        for(var j = 0; j < _topicIds[i].Length; j++){
            var currentIdValue = _topicIds[i][j];
            if(uniqueIds.IndexOf(currentIdValue)  == -1){
                uniqueIds.Add(currentIdValue);
            }
        }
    }
    uniqueIds.Sort();

    var unigueIdArray = new int[uniqueIds.Count];

    for(var i = 0; i < unigueIdArray.Length; i++){
        unigueIdArray[i] = uniqueIds[i];
    }

    return unigueIdArray;
}
