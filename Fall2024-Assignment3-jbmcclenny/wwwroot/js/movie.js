
async function generateMovieReview() {
    
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
    } catch (error) {
        console.error("Failed to generate movie reviews: ", error.message);
        return false;
    }
}
