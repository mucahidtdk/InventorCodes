            WorkPlane Plane = AssemblyData.Acd.WorkPlanes["Work Plane37"];
            object PlaneProxy;
            AssemblyData.Occ.CreateGeometryProxy(Plane, out PlaneProxy);
            return PlaneProxy;
