async function generateMovieReview() {
    const response = await fetch('OPENAI_API_ENDPOINT', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer OPENAI_API_KEY`
        },
        body: JSON.stringify({
            prompt: `Write a review for the movie titled "${document.getElementById('Name').value}"`,
            max_tokens: 150
        })
    });

    const data = await response.json();
    return data.choices[0].text.trim();
}

async function generateMovieReviews() {
    const reviewsList = [];
    for (let i = 0; i < 10; i++) {
        const review = await generateMovieReview();
        reviewsList.push({
            Id: i + 1,
            Author: getRandomName(),
            Review: review
        });
    }
    return reviewsList;
}

async function createMovie() {
    try {
        const reviewsList = await generateMovieReviews();
        const reviewsJson = JSON.stringify(reviewsList);
        document.getElementById('ReviewsList').value = reviewsJson;
        return true;
    } catch {
        console.log('Failed to generate movie reviews');
        return false;
    }
}
