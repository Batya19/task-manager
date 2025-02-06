import axios from 'axios';

const apiUrl = process.env.REACT_APP_API_URL;
axios.defaults.baseURL = apiUrl;

axios.interceptors.response.use(
  response => response,
  error => {
    console.error('API Error:', error);
    return Promise.reject(error);
  }
);

export default {
  getTasks: async () => {
    const result = await axios.get(`${apiUrl}/items`)
    return result.data;
  },

  addTask: async (name) => {
    const result = await axios.post(`${apiUrl}/items`, { name })
    return result.data;
  },

  setCompleted: async (id, isComplete, name) => {
    const result = await axios.put(`${apiUrl}/items/${id}`, {
      isComplete,
      Name: name
    });
    return result.data;
  },

  deleteTask: async (id) => {
    await axios.delete(`/items/${id}`);
    return { message: 'Task deleted successfully' };
  }
};
