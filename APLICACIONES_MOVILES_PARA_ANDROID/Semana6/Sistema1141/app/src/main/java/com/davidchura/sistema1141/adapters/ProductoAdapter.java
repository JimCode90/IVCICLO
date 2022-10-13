package com.davidchura.sistema1141.adapters;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.davidchura.sistema1141.R;
import com.davidchura.sistema1141.utils.Total;
import com.squareup.picasso.Picasso;

import java.util.ArrayList;
import java.util.HashMap;

public class ProductoAdapter extends RecyclerView.Adapter<ProductoAdapter.ViewHolder>{
    ArrayList<HashMap<String,String>> arrayList;
    public ProductoAdapter(ArrayList<HashMap<String,String>> arrayList) {
        this.arrayList = arrayList;
    }

    @NonNull
    @Override
    public ProductoAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.item_producto,parent,false);
        return new ProductoAdapter.ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull ProductoAdapter.ViewHolder holder, int position) {
        HashMap<String,String> map = arrayList.get(position);
        holder.tvProductoNombre.setText(map.get("nombre"));
        float precio = Float.parseFloat(map.get("precio"));
        holder.tvProductoPrecio.setText("S/." + String.format("%.2f", precio));
        String ruta = Total.rutaServicio + map.get("imagenchica");
        Picasso.get().load(ruta).into(holder.ivProductoFoto);
        if (map.get("imagenchica") == "null"){
            Picasso.get().load(R.drawable.nophoto).into(holder.ivProductoFoto);
        }
    }

    @Override
    public int getItemCount() {
        return arrayList.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        TextView tvProductoNombre, tvProductoPrecio;
        ImageView ivProductoFoto;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            tvProductoNombre = itemView.findViewById(R.id.tvProductoNombre);
            tvProductoPrecio = itemView.findViewById(R.id.tvProductoPrecio);
            ivProductoFoto = itemView.findViewById(R.id.ivProductoFoto);
        }
    }
}

