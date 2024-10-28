async function generateReviews(movieId, movieName) {
    const reviews = [];
    for (let i = 0; i < 10; i++) {
        const response = await fetch('OPENAI_API_ENDPOINT', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': `Bearer OPENAI_API_KEY`
            },
            body: JSON.stringify({
                prompt: `Write a review for movie ${movieName}.`,
                max_tokens: 150
            })
        });
        const data = await response.json();
        const comment = data.choices[0].text.trim();

        reviews.push({
            movieId: movieId,
            reviewId: i + 1,
            reviewer: `Reviewer ${i + 1}`,
            rating: Math.random() % 5 + 1,
            comment: comment
        });
    }
    return reviews;
}

// Group all the reviews together then analyze the sentiment of all the reviews using OpenAI API
async function analyzeSentiment(reviews) {
    const allReviews = reviews.map(review => review.comment).join(' ');
    const response = await fetch('OPENAI_API_ENDPOINT', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer OPENAI_API_KEY`
        },
        body: JSON.stringify({
            prompt: `Analyze the sentiment of the following text: ${allReviews}`,
            max_tokens: 150
        })
    });
    const data = await response.json();
    const sentiment = data.choices[0].text.trim();
    return sentiment;
}

// Generate 20 tweets about the actor using OpenAI API
async function generateTweets(actorName) {
    const tweets = [];
    for (let i = 0; i < 20; i++) {
        const response = await fetch('OPENAI_API_ENDPOINT', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': `Bearer OPENAI_API_KEY`
            },
            body: JSON.stringify({
                prompt: `Write a tweet about ${actorName}.`,
                max_tokens: 150
            })
        });
        const data = await response.json();
        const tweet = data.choices[0].text.trim();

        tweets.push({
            tweetId: i + 1,
            tweet: tweet
        });
    }
    return tweets;
}

// Analyze the sentiment of tweets about the actor using OpenAI API
async function analyzeActorSentiment(tweets) {
    const allTweets = tweets.map(tweet => tweet.tweet).join(' ');
    const response = await fetch('OPENAI_API_ENDPOINT', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer OPENAI_API_KEY`
        },
        body: JSON.stringify({
            prompt: `Analyze the sentiment of the following text: ${allTweets}`,
            max_tokens: 150
        })
    });
    const data = await response.json();
    const sentiment = data.choices[0].text.trim();
    return sentiment;
}

// FOR MOVIE FORM

// Add a new actor input field to the form
function addActor() {
    var container = document.getElementById('actors-list-container');
    var index = container.children.length;
    var newActor = document.createElement('div');
    newActor.className = 'actor-item';
    newActor.innerHTML = `
        <input name="ActorsList[\${index}]" class="form-control" />
        <button type="button" class="btn btn-danger" onclick="removeActor(this)">Remove</button>
        <span class="text-danger"></span>
    `;
    container.appendChild(newActor);
}

// Remove an actor input field from the form
function removeActor(button) {
    var container = document.getElementById('actors-list-container');
    container.removeChild(button.parentElement);
}

$(document).ready(function () {


});