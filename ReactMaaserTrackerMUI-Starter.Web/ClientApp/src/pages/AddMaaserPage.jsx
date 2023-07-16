import React, {useState} from 'react';
import { Container, TextField, Button, Typography } from '@mui/material';
import dayjs from 'dayjs';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const AddMaaserPage =() => {
    const nav = useNavigate();
    const [selectedDate, setSelectedDate] = useState(new Date());
    const [recipient, setRecipient] = useState('');
    const [amount, setAmount ] = useState(0); 

    const onAddClick = async () => {
        await axios.post("/api/maaser/addmaaserdeposit", {  recipient, amount, date: selectedDate });
        nav('/maaser');
    }


    return (
        <Container maxWidth="sm" sx={{ display: 'flex', flexDirection: 'column', justifyContent: 'center', height: '80vh' }}>
            <Typography variant="h2" component="h1" gutterBottom>
                Add Maaser
            </Typography>
            <TextField label="Recipient" variant="outlined" value={recipient} onChange={(e) => setRecipient(e.target.value)}fullWidth margin="normal" />
            <TextField label="Amount" variant="outlined" InputProps={{ inputProps: { min: 0, step: 0.01 } }} value={amount} onChange={(e) => setAmount(e.target.value)} type="number" fullWidth margin="normal" />
            <TextField
                label="Date"
                type="date"
                value={dayjs(selectedDate).format('YYYY-MM-DD')}
                onChange={e => setSelectedDate(e.target.value)}
                renderInput={(params) => <TextField {...params} fullWidth margin="normal" variant="outlined" />}
            />
            <Button variant="contained" onClick={onAddClick} color="primary">Add Maaser</Button>
        </Container>
    );
}

export default AddMaaserPage;
