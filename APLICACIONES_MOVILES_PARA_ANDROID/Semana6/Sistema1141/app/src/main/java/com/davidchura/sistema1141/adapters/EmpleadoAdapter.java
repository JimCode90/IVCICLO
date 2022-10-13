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

public class EmpleadoAdapter  extends RecyclerView.Adapter<EmpleadoAdapter.ViewHolder>{
    ArrayList<HashMap<String,String>> arrayList;
    public EmpleadoAdapter(ArrayList<HashMap<String,String>> arrayList) {
        this.arrayList = arrayList;
    }

    @NonNull
    @Override
    public EmpleadoAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.item_empleado,parent,false);
        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull EmpleadoAdapter.ViewHolder holder, int position) {
        HashMap<String,String> map = arrayList.get(position);
        holder.tvEmpleadoNombreCompleto.setText(map.get("nombres") + " " + map.get("apellidos"));
        holder.tvEmpleadoCargo.setText(map.get("cargo"));
        String ruta = Total.rutaServicio + "fotos/" + map.get("foto");
        Picasso.get().load(ruta).into(holder.ivEmpleadoFoto);
    }

    @Override
    public int getItemCount() {
        return arrayList.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        TextView tvEmpleadoNombreCompleto, tvEmpleadoCargo;
        ImageView ivEmpleadoFoto;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            tvEmpleadoNombreCompleto = itemView.findViewById(R.id.tvEmpleadoNombreCompleto);
            tvEmpleadoCargo = itemView.findViewById(R.id.tvEmpleadoCargo);
            ivEmpleadoFoto = itemView.findViewById(R.id.ivEmpleadoFoto);
        }
    }
}
