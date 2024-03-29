import { debounce, TextField } from "@mui/material";
import { useState } from "react";
import { useAppDispatch, useAppSelector } from "../../store/configureStore";
import { setProductParams } from "./catalogSlice";

export default function ProductSearch() {
    const { productParams } = useAppSelector(state => state.catalog);
    const [searchTerm, setSearchTerm] = useState(productParams.searchTerm);


    const debouncedSearch = debounce((event: any) => {
        dispatch(setProductParams({ searchTerm: event.target.value }))
    }, 1000)
    
    const dispatch = useAppDispatch();
    return (
        <TextField
            label='Search products'
            variant='outlined'
            fullWidth
            value={searchTerm || ''}
            onChange={(event: any) => {
                setSearchTerm(event.target.value);
                debouncedSearch(event);
            }}
        />
    )
}