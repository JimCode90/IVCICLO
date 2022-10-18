package com.davidchura.sistema1141.adapters;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.davidchura.sistema1141.R;

import java.util.ArrayList;
import java.util.HashMap;

public class CategoriaAdapter extends RecyclerView.Adapter<CategoriaAdapter.ViewHolder> {
    ArrayList<HashMap<String,String>> arrayList;

    public static OnItemClickListener onItemClickListener;

    public CategoriaAdapter(ArrayList<HashMap<String,String>> arrayList) {
        this.arrayList = arrayList;
    }

    @NonNull
    @Override
    public CategoriaAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.item_categoria,parent,false);
        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull CategoriaAdapter.ViewHolder holder, int position) {
        HashMap<String,String> map = arrayList.get(position);
        holder.tvCategoriaNombre.setText(map.get("nombre"));
        holder.tvCategoriaDescripcion.setText(map.get("descripcion"));
    }

    @Override
    public int getItemCount() {
        return arrayList.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder implements View.OnClickListener {
        TextView tvCategoriaNombre, tvCategoriaDescripcion;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            tvCategoriaNombre = itemView.findViewById(R.id.tvCategoriaNombre);
            tvCategoriaDescripcion = itemView.findViewById(R.id.tvCategoriaDescripcion);
            itemView.setOnClickListener(this);
        }

        @Override
        public void onClick(View view) {
            Log.d("POSICION", String.valueOf(getLayoutPosition()));
            onItemClickListener.onItemClick(getLayoutPosition());
        }
    }
    public interface OnItemClickListener{
        void onItemClick(int position);
    }

    public void setOnItemClickListener(OnItemClickListener onItemClickListener){
        CategoriaAdapter.onItemClickListener = onItemClickListener;
    }

}
