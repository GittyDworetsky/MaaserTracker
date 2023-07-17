import React, { useState, useEffect } from 'react';
import { Container, Typography, Box, Paper } from '@mui/material';
import axios from 'axios';

const OverviewPage = () => {

  const [totalIncome, setTotalIncome] = useState(0);
  const [totalMaaser, setTotalMaaser] = useState(0);
  const maaserObligated = totalIncome / 10;

  useEffect(() => {

    const getTotals = async () => {

      const { data: income } = await axios.get("/api/maaser/gettotalincomeamount");
      setTotalIncome(income);
      const { data: maaser } = await axios.get("/api/maaser/gettotalmaaseramount");
      setTotalMaaser(maaser);

    }

    getTotals();

  }, [])

  return (
    <Container
      maxWidth="md"
      sx={{
        display: 'flex',
        flexDirection: 'column',
        justifyContent: 'center',
        alignItems: 'center',
        height: '80vh',
        textAlign: 'center'
      }}
    >
      <Paper elevation={3} sx={{ padding: '60px', borderRadius: '15px' }}>
        <Typography variant="h2" gutterBottom>
          Overview
        </Typography>
        <Box sx={{ marginBottom: '20px' }}>
          <Typography variant="h5" gutterBottom>
            Total Income: ${totalIncome.toFixed(2)}
          </Typography>
          <Typography variant="h5" gutterBottom>
            Total Maaser: ${totalMaaser.toFixed(2)}
          </Typography>
        </Box>
        <Box>
          <Typography variant="h5" gutterBottom>
            Maaser Obligated: ${maaserObligated.toFixed(2)}
          </Typography>
          <Typography variant="h5" gutterBottom>
            Remaining Maaser obligation: ${(maaserObligated - totalMaaser) > 0 ? (maaserObligated - totalMaaser).toFixed(2) : (0).toFixed(2)}
          </Typography>
        </Box>
      </Paper>
    </Container>
  );
}

export default OverviewPage;
