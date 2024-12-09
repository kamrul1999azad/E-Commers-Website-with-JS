const mongoose = require('mongoose');
const connectToDB = async () => {
    try {
        await mongoose.connect("mongodb+srv://kamrulazad2923:Azad1999@cluster0.o1sdbnr.mongodb.net/", {
            useNewUrlParser: true, useUnifiedTopology: true
        })
        console.log('Data Connected to MongoDB');} catch (error) {
        console.error(error);
    }
}
module.exports =connectToDB;