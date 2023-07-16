import React, { useState, useEffect } from 'react';
import { Container, TextField, Button, Autocomplete, Typography, autocompleteClasses } from '@mui/material';
import dayjs from 'dayjs';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';




const AddIncomePage = () => {
    const [selectedDate, setSelectedDate] = useState(new Date());
    const [amount, setAmount] = useState(0);
    const [selectedSource, setSelectedSource] = useState({});
    const [sources, setSources] = useState([]);

    const nav = useNavigate();

    useEffect(() => {

        const getSources = async () => {
            const { data } = await axios.get("/api/maaser/getallsources");
            setSources(data);
        }

        getSources();

    }, [])

    const onAddClick = async () => {
        await axios.post("/api/maaser/addincome", {  source: selectedSource.source, amount, datesubmitted: selectedDate });
        nav('/income');
    }
    


    return (
        <Container maxWidth="sm" sx={{ display: 'flex', flexDirection: 'column', justifyContent: 'center', height: '80vh' }}>
            <Typography variant="h2" component="h1" gutterBottom>
                Add Income
            </Typography>
            <Autocomplete
                options={sources}
                getOptionLabel={(option) => option.source}
                onChange={(e, value) => setSelectedSource(value)}
                fullWidth
                margin="normal"
                renderInput={(params) => <TextField {...params} label="Source" variant="outlined" />}
            />
            <TextField
                label="Amount"
                variant="outlined"
                type="number"
                value={amount}
                onChange={(e) => setAmount(e.target.value)}
                InputProps={{ inputProps: { min: 0, step: 0.01 } }}
                fullWidth
                margin="normal"
            />
            <TextField
                label="Date"
                type="date"
                value={dayjs(selectedDate).format('YYYY-MM-DD')}
                onChange={e => setSelectedDate(e.target.value)}
                renderInput={(params) => <TextField {...params} fullWidth margin="normal" variant="outlined" />}
            />
            <Button variant="contained" onClick={onAddClick} color="primary">Add Income</Button>
        </Container>
    );
}

export default AddIncomePage;
